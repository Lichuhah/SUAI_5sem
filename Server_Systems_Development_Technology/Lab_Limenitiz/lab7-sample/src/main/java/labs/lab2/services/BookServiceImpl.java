package labs.lab2.services;
//v
import labs.lab2.db.dao.BookRepository;
import labs.lab2.db.model.Book;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class BookServiceImpl implements BookService {

    @Autowired
    private BookRepository bbirjaRepository;
    @Override
    public Iterable<Book> listAll() {
        return bbirjaRepository.findAll();
    }

    @Override
    public void delete(Integer id) {
        bbirjaRepository.deleteById(id);
    }

    @Override
    public Book add(String nameCompany, Integer kolActives, Double priceActive) {
        return bbirjaRepository.save(new Book(nameCompany, kolActives, priceActive));
    }
}
