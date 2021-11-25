package suai.trsis2021.lab4.controller;

import com.google.gson.Gson;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import suai.trsis2021.lab4.entity.CostEntity;
import suai.trsis2021.lab4.exceptions.CostNotFoundException;
import suai.trsis2021.lab4.service.CostService;

import java.util.Arrays;

@RestController
@RequestMapping("/costs")
public class CostController {

    @Autowired
    private CostService costService;
    private static final Gson gson = new Gson();

    @PostMapping("add")
    public ResponseEntity<String> addCost(@RequestBody CostEntity cost){
        try {
            if(costService.addCost(cost)) {
                return ResponseEntity.status(HttpStatus.CREATED).body(gson.toJson("Cost added successfully"));
            }
            throw new CostNotFoundException(gson.toJson("Cost don't found"));
        } catch (CostNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        } catch (Exception e){
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("CostController error -> " + e.getMessage() +
                    "\n\n" + Arrays.toString(e.getStackTrace()));
        }
    }

    @DeleteMapping("delete/{id}")
    public ResponseEntity<String> deleteCost(@PathVariable Long id){
        try {
            if (costService.deleteCost(id)){
                return ResponseEntity.status(HttpStatus.OK).body(gson.toJson("Cost delete successfully"));
            }
            throw new CostNotFoundException("Cost don't found");
        } catch (CostNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(gson.toJson("CostController error"));
        }
    }

    @PutMapping("put/{id}")
    public ResponseEntity<String> putCost(@RequestBody CostEntity cost){
        try {
            if(costService.putCost(cost)) {
                return ResponseEntity.status(HttpStatus.ACCEPTED).body(gson.toJson("Cost updated successfully"));
            }
            throw new CostNotFoundException(gson.toJson("Cost don't found"));
        } catch (CostNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(gson.toJson("CostController error"));
        }
    }

    @GetMapping("get/all")
    public ResponseEntity<Object> getCostList(){
        try {
            return ResponseEntity.status(HttpStatus.OK).body(costService.getCosts());
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(gson.toJson("CostController error"));
        }
    }

    @GetMapping("get/{id}")
    public ResponseEntity<String> getCost(@PathVariable Long id){
        try {
            return ResponseEntity.status(HttpStatus.FOUND).body(gson.toJson(costService.getCost(id)));
        }catch (CostNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("CostController error");
        }
    }
}
