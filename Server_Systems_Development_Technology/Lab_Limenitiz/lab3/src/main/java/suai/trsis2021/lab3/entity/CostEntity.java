package suai.trsis2021.lab3.entity;

import lombok.*;
import org.hibernate.Hibernate;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.util.Objects;

@Entity
public class CostEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Getter         private Long id;
    @Getter @Setter private String name;
    @Getter @Setter private Integer price;
    @Getter @Setter private String category;
    @Getter @Setter private String customer;
    @Getter @Setter private Integer count;

    public CostEntity() {
        count = 1;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || Hibernate.getClass(this) != Hibernate.getClass(o)) return false;
        CostEntity that = (CostEntity) o;
        return id != null && Objects.equals(id, that.id);
    }

    @Override
    public int hashCode() {
        return 0;
    }
}
