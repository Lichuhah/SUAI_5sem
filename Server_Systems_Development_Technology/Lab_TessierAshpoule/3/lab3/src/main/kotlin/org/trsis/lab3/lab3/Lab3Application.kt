package org.trsis.lab3.lab3

import org.springframework.boot.autoconfigure.SpringBootApplication
import org.springframework.boot.runApplication
import org.springframework.web.servlet.config.annotation.ResourceHandlerRegistry

@SpringBootApplication
class Lab3Application {
	fun addResourceHandlers(registry: ResourceHandlerRegistry) {
		registry.addResourceHandler("/static/**").addResourceLocations("classpath:/static/")
	}
}

fun main(args: Array<String>) {
	runApplication<Lab3Application>(*args)
}