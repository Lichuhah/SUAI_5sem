package labs.lab2.rest;
//v
import labs.lab2.db.model.Book;
import labs.lab2.kafka.KafkaProducer;
import labs.lab2.services.BookService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.annotation.AuthenticationPrincipal;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.security.Principal;

@RestController
@RequestMapping("public/rest/birja")
public class BookRestService {

    @Autowired
    KafkaProducer kafkaProducer;

    @Autowired
    private BookService bbirjaService;

    @RequestMapping(value = "", method = RequestMethod.GET)
    public ResponseEntity<Object> browse() {
        return ResponseEntity.ok(bbirjaService.listAll());
    }

    @RequestMapping(value = "/{id}", method = RequestMethod.DELETE)
    public void delete(@PathVariable("id") Integer id, @AuthenticationPrincipal Principal principal) {

        if (principal == null) {
            throw new ForbiddenException();
        }
        bbirjaService.delete(id);
    }

    @RequestMapping(value = "/{companyname}/{kolactives}/{priceactive}", method = RequestMethod.POST)
    public ResponseEntity<Object> add(@PathVariable("companyname") String nameCompany, @PathVariable("kolactives") Integer kolActives, @PathVariable("priceactive") Double priceActive, @AuthenticationPrincipal Principal principal) {
        if (principal == null) {
            throw new ForbiddenException();
        }

        Book bbirja = bbirjaService.add(nameCompany,kolActives,priceActive);
        try{
            kafkaProducer.sendMessage(bbirja);
        }
        catch (Exception e){
            return null;
        }
        return ResponseEntity.ok(bbirja);
    }

}
