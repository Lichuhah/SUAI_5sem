package suai.trsis2021.labs.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.view.RedirectView;

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
