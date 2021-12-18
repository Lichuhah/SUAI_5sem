package labs.lab2.services;
//v
import labs.lab2.db.model.Book;

public interface BookService {
    Iterable<Book> listAll();
    void delete(Integer id);
    Book add(String nameCompany, Integer kolActives, Double priceActive);
}
