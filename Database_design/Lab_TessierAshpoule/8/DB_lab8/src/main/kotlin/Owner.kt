import java.util.*
import javax.persistence.*

@Entity
@Table(name = "owner", schema = "bd_schema")
data class Owner(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id_owner", nullable = false)
    var Id: Long? = null,

    @Column(name = "Name", nullable = false)
    var Name: String? = null,

    @Column(name = "Surname", nullable = false)
    var Surnane: String? = null,

    @Column(name = "Middle_name", nullable = false)
    var Middle_name: String? = null
) {

}
