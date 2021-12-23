package labs.lab2.db.model;
//v
import lombok.AllArgsConstructor;
import lombok.Data;

import javax.persistence.*;
import java.io.Serializable;

@Entity
@Table(name = "birja")
@Data
@AllArgsConstructor
public class Book implements Serializable {
    private static final long serialVersionUID = 1L;

    public Book(String inputNameCompany, Integer inputKolActives, Double inputPriceActive){
        this.nameCompany = inputNameCompany;
        this.kolActives= inputKolActives;
        this.priceActive = inputPriceActive;
    }

    @Id
    @Column(name = "birja_id")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @Column(name = "birja_nameCompany")
    private String nameCompany;

    @Column(name = "birja_kolActives")
    private Integer kolActives;

    @Column(name = "birja_priceActive")
    private Double priceActive;

    public Book() {

    }
}
