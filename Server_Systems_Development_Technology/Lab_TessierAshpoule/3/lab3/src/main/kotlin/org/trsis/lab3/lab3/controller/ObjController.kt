package org.trsis.lab3.lab3.controller

import com.example.demo.data.Storage
import com.example.demo.data.objFactory
import org.springframework.http.ResponseEntity
import org.springframework.web.bind.annotation.*

@RestController
@RequestMapping("/obj")
class ObjController {
    /** добавление объекта в комнату */
    @PostMapping("/add")
    fun addObj(
        @RequestParam("name") name: String,
        @RequestParam("count") count: Int,
        @RequestParam("roomId") roomId: Int
    ) {
        val obj = objFactory(name, count)
        if (obj != null) {
            Storage.data.roomList
                .filter { it.id == roomId }
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
    @PutMapping("/put")
    fun putObj(
        @RequestParam("objName") objName: String,
        @RequestParam("roomId") roomId: Int,
        @RequestParam("count") count: Int
    ): ResponseEntity<String> {
        var f = false
        for (room in Storage.data.roomList)
            if (room.id == roomId)
                for (obj in room.listObj)
                    if (obj.name == objName) {
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
    @DeleteMapping("/delete")
    fun deleteObj(
        @RequestParam("objName") objName: String,
        @RequestParam("roomId") roomId: Int
    ): ResponseEntity<String> {
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