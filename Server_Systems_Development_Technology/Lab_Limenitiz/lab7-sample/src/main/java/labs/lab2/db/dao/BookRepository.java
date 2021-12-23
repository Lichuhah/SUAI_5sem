package labs.lab2.db.dao;
//v
import labs.lab2.db.model.Book;
import org.springframework.data.repository.CrudRepository;

public interface BookRepository extends CrudRepository<Book, Integer> {
}