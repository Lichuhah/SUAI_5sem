package suai.trsis2021.lab4.controller;

import lombok.extern.slf4j.Slf4j;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.view.RedirectView;

import java.io.File;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;

@Controller
public class WebController {

    @GetMapping("")
    public RedirectView redirect(){
        return new RedirectView("/home-page");
    }

    @RequestMapping("/login")
    public String login(){
        return "LoginPage";
    }

    @GetMapping("/home-page")
    public String homePage() {
        return "HomePage";
    }

    @GetMapping("/full-access-pane")
    public String getAdminPage(){
        return "FullAccessPane";
    }

    @GetMapping("/read-access-pane")
    public String getReadPage() {
        return "ReadAccessPane";
    }

    @GetMapping("/forbidden-error")
    public String getForbiddenPage() {
        return "ForbiddenPage";
    }

}
