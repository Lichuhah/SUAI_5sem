package labs.lab2;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.builder.SpringApplicationBuilder;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.servlet.configuration.EnableWebMvcSecurity;

@ComponentScan
@EnableAutoConfiguration
@EnableWebSecurity
public class Lab2Application {

    public static void main(String[] args) {
        SpringApplication app = new SpringApplicationBuilder(Lab2Application.class).build();
        app.run(args);
    }

}
