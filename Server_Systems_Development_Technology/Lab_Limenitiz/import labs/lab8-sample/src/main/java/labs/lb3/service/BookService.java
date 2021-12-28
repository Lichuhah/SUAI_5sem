package labs.lb3.service;

import labs.lb3.model.ClassBook;

import java.util.List;

public interface BookService {

    void create(ClassBook birjaCompany);
    List<ClassBook> readAll();
    ClassBook read(int id);
    boolean update(ClassBook birjaCompany, int id);
    boolean delete(int id);
}
