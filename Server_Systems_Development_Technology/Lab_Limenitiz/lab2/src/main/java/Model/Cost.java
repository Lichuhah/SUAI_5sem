package Model;

import Model.Items.Customer;
import Model.Items.Name;
import Model.Items.Price;
import Model.Items.Category;

public class Cost {
    private int id;
    private Name name;
    private Price price;
    private Category category;
    private Customer customer;

    public Cost(int id, Name name, Price price, Category category, Customer customer) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.category = category;
        this.customer = customer;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Name getName() {
        return name;
    }

    public void setName(Name name) {
        this.name = name;
    }

    public Price getPrice() {
        return price;
    }

    public void setPrice(Price price) {
        this.price = price;
    }

    public Category getCategory() {
        return category;
    }

    public void setCategory(Category category) {
        this.category = category;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }
}
