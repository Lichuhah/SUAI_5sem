package suai.trsis2021.lab3.model;

import lombok.*;
import suai.trsis2021.lab3.entity.CostEntity;

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

    @Getter         private Long id;
    @Getter @Setter private String name;
    @Getter @Setter private Integer price;
    @Getter @Setter private String category;
    @Getter @Setter private String customer;
    @Getter @Setter private Integer count;

    public Cost() {
        count = 1;
    }
}
