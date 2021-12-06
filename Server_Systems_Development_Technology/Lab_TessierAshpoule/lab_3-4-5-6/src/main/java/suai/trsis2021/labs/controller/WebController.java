package suai.trsis2021.labs.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.view.RedirectView;

@Controller
public class WebController {

    @GetMapping("")
    public RedirectView redirect(){
        return new RedirectView("/home");
    }

    @RequestMapping("/login")
    public String login(){
        return "LoginPage";
    }

    @GetMapping("/home")
    public String homePage() {
        return "HomePage";
    }

    @GetMapping("/crud-pane")
    public String getAdminPage(){
        return "CrudPane";
    }

    @GetMapping("/read-pane")
    public String getReadPage() {
        return "ReadPane";
    }

    @GetMapping("/forbidden-page")
    public String getForbiddenPage() {
        return "ForbiddenPage";
    }

}
