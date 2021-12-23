package org.trsis.lab3.lab3

import org.springframework.stereotype.Controller
import org.springframework.web.bind.annotation.GetMapping

@Controller
class WebController {

    @GetMapping("/")
    fun MainP() = "index.html"

    @GetMapping("/roomAdd")
    fun RoomA() = "RoomAdd.html"

    @GetMapping("/roomDelete")
    fun RoomG() = "RoomDelete.html"

    @GetMapping("/objAdd")
    fun ObjA() = "ObjAdd.html"

    @GetMapping("/objEdit")
    fun ObjE() = "ObjEdit.html"

    @GetMapping("/objDelete")
    fun ObjD() = "ObjDelete.html"

    @GetMapping("/ri")
    fun RI() = "RoomIndex.html"

    @GetMapping("/rf")
    fun RF() = "RoomForm.html"
}