package org.trsis.lab3.lab3.controller

import com.example.demo.data.Storage
import com.example.demo.data.objFactory
import org.springframework.http.ResponseEntity
import org.springframework.web.bind.annotation.*

@RestController
class ObjController {
    /** добавление объекта в комнату */
    @RequestMapping(value = ["obj/add"], method = [RequestMethod.POST])
    fun addObj(@RequestBody body: String): ResponseEntity<String> {
        val obj = objFactory(
            body.substringAfter("""e":"""").substringBefore("""","id":""""),
            body.substringAfter("""","id":"""").substringBefore("""","roomId":"""").toInt())
        return if (obj != null) {
            Storage.data.roomList
                .filter { it.id == body.substringAfter(""","roomId":"""").substringBefore(""""}""").toInt() }
                .forEach { it.put(obj) }

            ResponseEntity
                .ok()
                .body("successfully")
        } else
            ResponseEntity
                .badRequest()
                .body("incorrect data")
    }

    /** Изменение количества объектов */
    @RequestMapping(value = ["obj/put"], method = [RequestMethod.PUT])
    fun putObj(@RequestBody body: String): ResponseEntity<String> {
        val name = body.substringAfter("""{"Name":"""").substringBefore("""","roomId":"""")
        val roomId = body.substringAfter("""","roomId":"""").substringBefore("""","count":"""").toInt()
        val count = body.substringAfter("""","count":"""").substringBefore(""""}""").toInt()
        var f = false
        for (room in Storage.data.roomList)
            if (room.id == roomId)
                for (obj in room.listObj)
                    if (obj.name == name ) {
                        f = true
                        obj.count = count
                    }
        return if (f)
            ResponseEntity
                .ok()
                .body("successfully")
        else
            ResponseEntity
                .badRequest()
                .body("error")
    }

    /** Удаление объекта */
    @RequestMapping(value = ["obj/delete"], method = [RequestMethod.DELETE])
    fun deleteObj(@RequestBody body: String ): ResponseEntity<String> {
        val objName = body.substringAfter("""{"Name":"""").substringBefore("""","roomId":"""")
        val roomId = body.substringAfter("""","roomId":"""").substringBefore(""""}""").toInt()
        var f = false
        for (room in Storage.data.roomList)
            if (room.id == roomId)
                for (i in 0 until room.listObj.size)
                    if (room.listObj[i].name == objName) {
                        f = true
                        room.listObj.removeAt(i)
                    }
        return if (f)
            ResponseEntity
                .ok()
                .body("successfully")
        else
            ResponseEntity
                .badRequest()
                .body("error")
    }
}