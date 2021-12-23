package suai.trsis2021.lab2.model;

import suai.trsis2021.lab2.entity.CostEntity;

public class Cost {

    public static Cost toModel(CostEntity entity){
        Cost cost = new Cost();
        cost.id = entity.getId();
        cost.name = entity.getName();
        cost.price = entity.getPrice();
        cost.category = entity.getCategory();
        cost.customer = entity.getCustomer();
        cost.count = entity.getCount();
        return cost;
    }

    private Long id;
    private String name;
    private Integer price;
    private String category;
    private String customer;
    private Integer count;

    public Cost() {
        count = 1;
    }

    public Long getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer getPrice() {
        return price;
    }

    public void setPrice(Integer price) {
        this.price = price;
    }

    public String getCategory() {
        return category;
    }

    public void setCategory(String category) {
        this.category = category;
    }

    public String getCustomer() {
        return customer;
    }

    public void setCustomer(String customer) {
        this.customer = customer;
    }

    public Integer getCount() {
        return count;
    }

    public void setCount(Integer count) {
        this.count = count;
    }
}
