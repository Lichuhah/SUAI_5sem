package labs.lb3.service;

import labs.lb3.model.ClassBook;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.concurrent.atomic.AtomicInteger;

@Service
public class BookServiceImpl implements BookService {

    // Хранилище клиентов
    private static final Map<Integer, ClassBook> BIRJA_REPOSITORY_MAP = new HashMap<>();

    // Переменная для генерации ID клиента
    private static final AtomicInteger BIRJA_ID_HOLDER = new AtomicInteger();

    @Override
    public void create(ClassBook Object) {
        final int birjaId = BIRJA_ID_HOLDER.incrementAndGet();
        Object.setId(birjaId);
        BIRJA_REPOSITORY_MAP.put(birjaId, Object);
    }

    @Override
    public List<ClassBook> readAll() {
        return new ArrayList<>(BIRJA_REPOSITORY_MAP.values());
    }

    @Override
    public ClassBook read(int id) {
        return BIRJA_REPOSITORY_MAP.get(id);
    }

    @Override
    public boolean update(ClassBook Object, int id) {
        if (BIRJA_REPOSITORY_MAP.containsKey(id)) {
            Object.setId(id);
            BIRJA_REPOSITORY_MAP.put(id, Object);
            return true;
        }

        return false;
    }

    @Override
    public boolean delete(int id) {
        return BIRJA_REPOSITORY_MAP.remove(id) != null;
    }

}
