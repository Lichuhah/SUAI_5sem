package suai.trsis2021.lab3.repository;

import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;
import suai.trsis2021.lab3.entity.CostEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface CostRepository extends CrudRepository<CostEntity, Long> {

    @Modifying
    @Query("update cost_entity c " +
            "set c.name = ?1, " +
            "   c.price = ?2," +
            "   c.category = ?3," +
            "   c.customer = ?4," +
            "   c.count = ?5 " +
            "where c.id = ?6")
    void updateCostById(String name,
                     Integer price,
                     String category,
                     String customer,
                     Integer count,
                     Long id);

    List<CostEntity> findByName(String name);
    Optional<CostEntity> findById(Long id);
}
