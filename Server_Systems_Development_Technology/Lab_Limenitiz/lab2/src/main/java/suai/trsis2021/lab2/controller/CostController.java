package suai.trsis2021.lab2.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import suai.trsis2021.lab2.entity.CostEntity;
import suai.trsis2021.lab2.exceptions.CostNotFoundException;
import suai.trsis2021.lab2.repository.CostRepository;
import suai.trsis2021.lab2.service.CostService;

import java.io.File;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;

@RestController
@RequestMapping("/costs")
public class CostController {

    @Autowired
    private CostService costService;

    @PostMapping("add")
    public ResponseEntity<String> addCost(@RequestBody CostEntity cost){
        try {
            if(costService.addCost(cost)) {
                return ResponseEntity.ok("Cost save");
            }
            throw new Exception("Cost don't save");
        }catch (Exception e){
            return ResponseEntity.badRequest().body("CostController");
        }
    }

    @GetMapping("table-view")
    public ResponseEntity getCostTable(){
        try {
            return ResponseEntity.ok(costService.getCosts());
        }catch (Exception e){
            return ResponseEntity.badRequest().body("CostController error");
        }
    }

    @GetMapping("")
    public ResponseEntity getCost(@RequestParam Long id){
        try {
            return ResponseEntity.ok(costService.getCost(id));
        }catch (CostNotFoundException e){
            return ResponseEntity.badRequest().body(e.getMessage());
        }catch (Exception e){
            return ResponseEntity.badRequest().body("CostController error");
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity deleteCost(@PathVariable Long id){
        try {
            return ResponseEntity.ok(costService.deleteCost(id));
        }catch (Exception e){
            return ResponseEntity.badRequest().body("CostController error");
        }
    }
}
