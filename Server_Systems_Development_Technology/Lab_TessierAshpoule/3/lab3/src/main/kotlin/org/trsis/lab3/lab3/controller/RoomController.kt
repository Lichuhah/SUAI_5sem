package org.trsis.lab3.lab3.controller

import org.springframework.web.bind.annotation.*;
import com.example.demo.data.Storage
import com.example.demo.data.erroreStorage
import com.google.gson.GsonBuilder
import org.springframework.http.ResponseEntity

@RestController
class RoomController {
    val gsonBuilder = GsonBuilder().setPrettyPrinting().create()

    /** Получение списка комнат */
    @RequestMapping(value = ["room/all"], method = [RequestMethod.GET])
    fun getRoomList() =
        ResponseEntity
            .ok()
            .body(gsonBuilder.toJson(Storage.data))

    /** Получение комнаты */
    @RequestMapping(value = ["room/get"], method = [RequestMethod.GET])
    fun getRoomList(@RequestBody body: String) =
        ResponseEntity
            .ok()
            .body(gsonBuilder.toJson(
                Storage.data.roomList[
                        body.substringAfter("""""").substringBefore("""""").toInt()
                ]))

    /** Создание новой комнаты */
    @RequestMapping(value = ["room/add"], method = [RequestMethod.POST])
    fun addRoom(@RequestBody body: String) =
        if (Storage.addRoom(
                body.substringAfter("""{"name":"""").substringBefore("""","id":""""),
                body.substringAfter("""","id":"""").substringBefore(""""}""").toInt()))
            ResponseEntity
                .ok()
                .body("successfully")
        else
            ResponseEntity
                .badRequest()
                .body(erroreStorage.lastError)


    /** Удаление комнаты */
    @RequestMapping(value = ["room/delete"], method = [RequestMethod.DELETE])
    fun deleteRoom(@RequestBody body: String) =
        if (Storage.deleteRoom(
                body.substringAfter("""d":"""")
                    .substringBefore(""""}""").toInt()))
            ResponseEntity
                .ok()
                .body("successfully")
        else
            ResponseEntity
                .badRequest()
                .body(erroreStorage.lastError)

}