package suai.trsis2021.labs.entity;

import lombok.*;

import javax.persistence.*;
import java.time.LocalDate;

@Table(schema = "trsis_tessier")
@Entity(name = "item")
public class ItemEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Getter @Setter private Long id;
    @Getter @Setter private String section;
    @Getter @Setter private String name;
    @Getter @Setter private Integer count;

    @Column(name = "date_add")
    @Getter @Setter private String dateAdd;
    @Column(name = "storage_time")
    @Getter @Setter private Integer storageTime;
    @Column(name = "storage_price")
    @Getter @Setter private Integer storagePrice;

    public ItemEntity() { count = 1; }

    public void countUp(){
        count += 1;
    }

    public void countDown(){
        count -= 1;
    }
}
