package suai.trsis2021.lab4.controller;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.apache.kafka.clients.consumer.ConsumerRecord;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.annotation.KafkaListener;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import suai.trsis2021.lab4.entity.CostEntity;
import suai.trsis2021.lab4.kafka.KafkaConsumer;
import suai.trsis2021.lab4.kafka.KafkaProducer;
import suai.trsis2021.lab4.repository.CostRepository;

@RestController
public class KafkaController {
    @Autowired
    KafkaProducer producer;

    @Autowired
    KafkaConsumer consumer;

    @PostMapping("/kafka-add")
    public String sendMessage(@RequestBody CostEntity cost) throws JsonProcessingException {
        this.producer.sendMessage(cost);
        return "Successfully";
    }
}
