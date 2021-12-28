package labs.lb3.rest;

import labs.lb3.service.BookService;
import labs.lb3.model.ClassBook;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class BookController {

    private final BookService bookService;

    @Autowired
    public BookController(BookService bookService) {
        this.bookService = bookService;
    }

    @PostMapping(value = "/public/rest/company")
    public ResponseEntity<?> create(@RequestBody ClassBook Object) {
        bookService.create(Object);
        return new ResponseEntity<>(HttpStatus.CREATED);
    }

    @GetMapping(value = "/public/rest/company")
    public ResponseEntity<List<ClassBook>> read() {
        final List<ClassBook> Object = bookService.readAll();

        return new ResponseEntity<>(Object, HttpStatus.OK);
    }

    @GetMapping(value = "/public/rest/company/{id}")
    public ResponseEntity<ClassBook> read(@PathVariable(name = "id") int id) {
        final ClassBook Object = bookService.read(id);

        return Object != null
                ? new ResponseEntity<>(Object, HttpStatus.OK)
                : new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    @PutMapping(value = "/public/rest/company/{id}")
    public ResponseEntity<?> update(@PathVariable(name = "id") int id, @RequestBody ClassBook Object) {
        final boolean updated = bookService.update(Object, id);

        return updated
                ? new ResponseEntity<>(HttpStatus.OK)
                : new ResponseEntity<>(HttpStatus.NOT_MODIFIED);
    }

    @DeleteMapping(value = "/public/rest/company/{id}")
    public ResponseEntity<?> delete(@PathVariable(name = "id") int id) {
        final boolean deleted = bookService.delete(id);

        return deleted
                ? new ResponseEntity<>(HttpStatus.OK)
                : new ResponseEntity<>(HttpStatus.NOT_MODIFIED);
    }
}
