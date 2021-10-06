package suai.trsis2021.lab2.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import suai.trsis2021.lab2.entity.CostEntity;
import suai.trsis2021.lab2.exceptions.CostNotFoundException;
import suai.trsis2021.lab2.model.Cost;
import suai.trsis2021.lab2.repository.CostRepository;

import java.util.LinkedList;
import java.util.List;

@Service
public class CostService {

    @Autowired
    private CostRepository costRepository;

    public boolean addCost(CostEntity cost){
        try {
            CostEntity find_cost = costRepository.findByName(cost.getName());

            if (find_cost != null){
                for (var c : costRepository.findAll()) {
                    if(c.equals(find_cost)){
                        find_cost.setCount(find_cost.getCount()+1);
                        return true;
                    }
                }
            }
            else{
                costRepository.save(cost);
                return true;
            }

            return false;
        }
        catch (Exception e){
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
}
