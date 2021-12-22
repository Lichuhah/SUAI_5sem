package suai.trsis2021.labs.controller;

import com.google.gson.Gson;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import suai.trsis2021.labs.entity.ItemEntity;
import suai.trsis2021.labs.exceptions.ItemNotFoundException;
import suai.trsis2021.labs.service.ItemService;

import java.util.Arrays;

@RestController
@RequestMapping("/items")
public class RestApiController {

    @Autowired
    private ItemService itemService;
    private static final Gson gson = new Gson();

    @PostMapping("add")
    public ResponseEntity<String> addCost(@RequestBody ItemEntity cost){
        try {
            if(itemService.addItem(cost)) {
                return ResponseEntity.status(HttpStatus.CREATED).body(gson.toJson("Item added successfully"));
            }
            throw new ItemNotFoundException(gson.toJson("Item don't found"));
        } catch (ItemNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        } catch (Exception e){
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("RestApiController error -> " + e.getMessage() +
                    "\n\n" + Arrays.toString(e.getStackTrace()));
        }
    }

    @DeleteMapping("delete/{id}")
    public ResponseEntity<String> deleteCost(@PathVariable Long id){
        try {
            if (itemService.deleteItem(id)){
                return ResponseEntity.status(HttpStatus.OK).body(gson.toJson("Item delete successfully"));
            }
            throw new ItemNotFoundException("Item don't found");
        } catch (ItemNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(gson.toJson("RestApiController error"));
        }
    }

    @PutMapping("put/{id}")
    public ResponseEntity<String> putCost(@RequestBody ItemEntity cost){
        try {
            if(itemService.putItem(cost)) {
                return ResponseEntity.status(HttpStatus.ACCEPTED).body(gson.toJson("Item updated successfully"));
            }
            throw new ItemNotFoundException(gson.toJson("Item don't found"));
        } catch (ItemNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(gson.toJson("RestApiController error"));
        }
    }

    @GetMapping("get/all")
    public ResponseEntity<Object> getCostList(){
        try {
            return ResponseEntity.status(HttpStatus.OK).body(itemService.getItems());
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(gson.toJson("RestApiController error"));
        }
    }

    @GetMapping("get/{id}")
    public ResponseEntity<String> getCost(@PathVariable Long id){
        try {
            return ResponseEntity.status(HttpStatus.FOUND).body(gson.toJson(itemService.getItem(id)));
        }catch (ItemNotFoundException e){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body(gson.toJson(e.getMessage()));
        }catch (Exception e){
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("RestApiController error");
        }
    }
}
