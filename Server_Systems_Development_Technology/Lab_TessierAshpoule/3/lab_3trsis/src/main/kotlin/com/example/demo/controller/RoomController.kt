package com.example.demo.controller

import com.example.demo.data.Storage
import com.example.demo.data.erroreStorage
import com.example.demo.data.objFactory
import com.google.gson.GsonBuilder
import org.springframework.http.ResponseEntity
import org.springframework.web.bind.annotation.*

@RestController
@RequestMapping("/room")
class RoomController {

    val gsonBuilder = GsonBuilder() .setPrettyPrinting() .create()

    /** Получение списка комнат */
    @GetMapping("/get")
    fun getRoomList() =
        ResponseEntity
            .ok()
            .body( gsonBuilder.toJson(Storage.data) )

    /** Создание новой комнаты */
    @PostMapping("/add")
    fun addRoom(@RequestParam("name") name: String,@RequestParam("id") id: Int) =
        if ( Storage.addRoom(name, id) )
            ResponseEntity
            .creator()
            .body("successfully")
        else
            ResponseEntity
            .badRequest()
            .body(erroreStorage.lastError)


    /** Удаление комнаты */
    @DeleteMapping("/delete")
    fun deleteRoom(@RequestParam("id") id: Int) =
        if  ( Storage.deleteRoom(id) )
            ResponseEntity
            .ok()
            .body("successfully")
        else
            ResponseEntity
            .badRequest()
            .body(erroreStorage.lastError)

}