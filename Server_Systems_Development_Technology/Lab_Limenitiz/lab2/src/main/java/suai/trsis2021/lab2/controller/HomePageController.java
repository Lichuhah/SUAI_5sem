package suai.trsis2021.lab2.controller;

import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.view.RedirectView;
import suai.trsis2021.lab2.Lab2Application;
import suai.trsis2021.lab2.exceptions.CostNotFoundException;

import javax.swing.text.html.HTMLDocument;
import java.io.File;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.Objects;

@Controller
@RequestMapping("")
public class HomePageController {

    @GetMapping("")
    public RedirectView redirect(){
        return new RedirectView("/home-page");
    }


    @GetMapping("/home-page")
    public ResponseEntity<String> getCost() {
        try {
            Path path = new File("src/main/resources/templates/HomePage.html")
                    .getAbsoluteFile().toPath();
            String html = Files.readString(path, StandardCharsets.UTF_8);

            return ResponseEntity.ok(html);
        } catch (Exception e) {
            return ResponseEntity.badRequest().body("HomePageController error");
        }
    }
}
