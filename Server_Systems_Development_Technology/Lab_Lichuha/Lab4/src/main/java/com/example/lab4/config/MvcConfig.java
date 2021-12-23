package com.example.lab4.config;

import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.ViewControllerRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

@Configuration
public class MvcConfig implements WebMvcConfigurer {

    public void addViewControllers(ViewControllerRegistry registry) {
        registry.addViewController("/home").setViewName("MainMenu");
        registry.addViewController("/").setViewName("MainMenu");
        registry.addViewController("/hello").setViewName("MainMenu");
        registry.addViewController("/login").setViewName("login");
    }

}