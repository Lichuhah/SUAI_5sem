package suai.trsis2021.labs.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;
import suai.trsis2021.labs.entity.ItemEntity;

import java.time.LocalDate;
import java.util.List;
import java.util.Optional;

@Repository
public interface ItemRepository extends JpaRepository<ItemEntity, Long> {

    @Modifying
    @Query("update item i " +
            "set i.section = ?1, " +
            "    i.name = ?2," +
            "    i.dateAdd = ?3," +
            "    i.storageTime = ?4," +
            "    i.storagePrice = ?5," +
            "    i.count = ?6 " +
            "where i.id = ?7")
    void updateCostById(
            String section,
            String name,
            String dateAdd,
            Integer storageTime,
            Integer storagePrice,
            Integer count,
            Long id
    );

    List<ItemEntity> findByName(String name);
    Optional<ItemEntity> findById(Long id);
}
