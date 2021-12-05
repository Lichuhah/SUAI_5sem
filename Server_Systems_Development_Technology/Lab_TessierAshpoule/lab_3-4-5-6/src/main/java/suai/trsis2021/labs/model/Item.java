package suai.trsis2021.labs.model;

import lombok.*;
import suai.trsis2021.labs.entity.ItemEntity;

import java.time.LocalDate;

public class Item {

    public static Item toModel(ItemEntity entity){
        Item item = new Item();

        item.setId(entity.getId());
        item.setSection(entity.getSection());
        item.setName(entity.getName());
        item.setDateAdd(entity.getDateAdd());
        item.setStorageTime(entity.getStorageTime());
        item.setStoragePrice(entity.getStoragePrice());
        item.setCount(entity.getCount());

        return item;
    }

    @Getter @Setter private Long id;
    @Getter @Setter private String section;
    @Getter @Setter private String name;
    @Getter @Setter private LocalDate dateAdd;
    @Getter @Setter private Integer storageTime;
    @Getter @Setter private Integer storagePrice;
    @Getter @Setter private Integer count;

    public Item() {
        count = 1;
    }

    public void countUp(){
        count += 1;
    }

    public void countDown(){
        count -= 1;
    }

}
