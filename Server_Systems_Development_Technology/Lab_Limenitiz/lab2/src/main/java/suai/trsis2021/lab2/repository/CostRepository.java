package suai.trsis2021.lab2.repository;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;
import suai.trsis2021.lab2.entity.CostEntity;

@Repository
public interface CostRepository extends CrudRepository<CostEntity, Long> {
    CostEntity findByName(String name);
    CostEntity findByCustomer(String customer);
    CostEntity findByPrice(Integer price);
}
