package suai.trsis2021.lab3.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import suai.trsis2021.lab3.entity.CostEntity;
import suai.trsis2021.lab3.exceptions.CostNotFoundException;
import suai.trsis2021.lab3.model.Cost;
import suai.trsis2021.lab3.repository.CostRepository;

import java.util.LinkedList;
import java.util.List;
import java.util.Optional;

@Service
@Transactional
public class CostService {

    @Autowired
    private CostRepository costRepository;

    public boolean addCost(CostEntity cost){
        if(cost.getName() == null ||
                cost.getPrice() == null ||
                cost.getCustomer() == null ||
                cost.getCategory() == null) {
            return false;
        }

        try {
            CostEntity c = findCostEntity(cost);
            if(c == null){
                costRepository.save(cost);
            }
            else{
                c.countUp();
                updateCostById(c);
            }
            return true;
        }
        catch (Exception e){
            e.printStackTrace();
            return false;
        }
    }

    public boolean deleteCost(Long id){
        try {
            Optional<CostEntity> c = costRepository.findById(id);
            if(c.isEmpty()){
                return false;
            }

            CostEntity cost = c.get();
            if(cost.getCount() > 1){
                cost.countDown();
                updateCostById(cost);
            }
            else{
                costRepository.deleteById(id);
            }
            return true;

        }catch (Exception e){
            return false;
        }
    }

    public boolean putCost(CostEntity cost){
        if(cost.getName() == null ||
                cost.getPrice() == null ||
                cost.getCustomer() == null ||
                cost.getCategory() == null) {
            return false;
        }

        Optional<CostEntity> c = costRepository.findById(cost.getId());
        if(c.isEmpty()){
            return false;
        }

        CostEntity costEntity = c.get();
        costEntity.setName(cost.getName());
        costEntity.setPrice(cost.getPrice());
        costEntity.setCategory(cost.getCategory());
        costEntity.setCustomer(cost.getCustomer());
        updateCostById(costEntity);
        return true;
    }

    public List<Cost> getCosts(){
        List<Cost> costs = new LinkedList<>();
        costRepository.findAll().forEach(e -> costs.add(Cost.toModel(e)));
        return costs;
    }

    public Cost getCost(Long id) throws CostNotFoundException {
        var cost = costRepository.findById(id);
        if(cost.isEmpty()){
            throw new CostNotFoundException("Cost don't found");
        }
        return Cost.toModel(cost.get());
    }

    private boolean equalsCosts(CostEntity e1, CostEntity e2){
        return e1.getName().equals(e2.getName()) &&
                e1.getCustomer().equals(e2.getCustomer()) &&
                e1.getPrice().equals(e2.getPrice()) &&
                e1.getCategory().equals(e2.getCategory());
    }

    public CostEntity findCostEntity(CostEntity cost) {
        for (var c : costRepository.findByName(cost.getName())) {
            if (equalsCosts(c, cost)) {
                return c;
            }
        }
        return null;
    }

    private void updateCostById(CostEntity cost){
        costRepository.updateCostById(
                cost.getName(),
                cost.getPrice(),
                cost.getCategory(),
                cost.getCustomer(),
                cost.getCount(),
                cost.getId()
        );
    }
}
