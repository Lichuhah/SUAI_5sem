package org.trsis.lab3.lab3.controller

import org.springframework.http.HttpStatus
import org.springframework.http.MediaType
import org.springframework.stereotype.Controller
import org.springframework.ui.Model
import org.springframework.web.bind.annotation.*;
import com.example.demo.data.Storage
import com.example.demo.data.erroreStorage
import com.google.gson.GsonBuilder
import org.springframework.http.ResponseEntity
import org.springframework.web.bind.annotation.*

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
    fun getRoomList(@RequestParam("id") id: Int) =
        ResponseEntity
            .ok()
            .body(gsonBuilder.toJson(Storage.data.roomList[id]))

    /** Создание новой комнаты */
    @RequestMapping(value = ["room/add"], method = [RequestMethod.POST])
    fun addRoom(@RequestParam("name") name: String, @RequestParam("id") id: Int) =
        if (Storage.addRoom(name, id))
            ResponseEntity
                .ok()
                .body("successfully")
        else
            ResponseEntity
                .badRequest()
                .body(erroreStorage.lastError)


    /** Удаление комнаты */
    @RequestMapping(value = ["room/delete"], method = [RequestMethod.DELETE])
    fun deleteRoom(@RequestParam("id") id: Int) =
        if (Storage.deleteRoom(id))
            ResponseEntity
                .ok()
                .body("successfully")
        else
            ResponseEntity
                .badRequest()
                .body(erroreStorage.lastError)

}