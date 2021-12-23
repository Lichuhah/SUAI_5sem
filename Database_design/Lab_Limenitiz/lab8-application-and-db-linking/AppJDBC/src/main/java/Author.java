import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.io.Serial;
import java.io.Serializable;

@Entity
@NoArgsConstructor
@Table(name = "author", schema = "database_design_course")
public class Author implements Serializable {
    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Getter @Setter protected Long id_author;
    @Getter @Setter protected String firstNameAuthor;
    @Getter @Setter protected String secondNameAuthor;
    @Getter @Setter protected String thirdNameAuthor;
}
