package org.trsis.lab3.lab3.controller

import org.springframework.stereotype.Controller
import org.springframework.ui.Model
import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.PathVariable

@Controller
class WebController {
    @GetMapping("/")
    fun MainPage(): String {
        return "MainMenu"
    }

    @GetMapping("room/menu")
    fun DocIndex(): String {
        return "DoctorIndex"
    }

    @GetMapping("doctors/view{id}")
    fun DocGet(@PathVariable id: Int, model: Model): String {
        model.addAttribute("docId", id)
        return "DoctorForm"
    }

    @GetMapping("patients")
    fun PatIndex(): String {
        return "PatientIndex"
    }

    @GetMapping("patients/view{id}")
    fun PatGet(@PathVariable id: Int, model: Model): String {
        model.addAttribute("patId", id)
        return "PatientForm"
    }

    @GetMapping("appointments")
    fun AppIndex(): String {
        return "AppointmentsIndex"
    }

    @GetMapping("appointments/view")
    fun AppGet(): String {
        return "AppointmentForm"
    }
}
