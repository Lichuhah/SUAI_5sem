package suai.trsis2021.lab3.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import suai.trsis2021.lab3.entity.CostEntity;
import suai.trsis2021.lab3.exceptions.CostNotFoundException;
import suai.trsis2021.lab3.model.Cost;
import suai.trsis2021.lab3.repository.CostRepository;

import java.util.LinkedList;
import java.util.List;

@Service
public class CostService {

    @Autowired
    private CostRepository costRepository;

    public boolean addCost(CostEntity cost){
        try {
            for (var c : costRepository.findAll()) {
                if (equalsCosts(c, cost)) {
                    int count = c.getCount();
                    costRepository.delete(c);
                    cost.setCount(count+1);
                    costRepository.save(cost);
                    return true;
                }
            }


            costRepository.save(cost);
            return true;
        }
        catch (Exception e){
            e.printStackTrace();
            return false;
        }
    }

    public boolean deleteCost(Long id){
        try {
            costRepository.deleteById(id);
            return true;
        }catch (Exception e){
            return false;
        }
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
}
