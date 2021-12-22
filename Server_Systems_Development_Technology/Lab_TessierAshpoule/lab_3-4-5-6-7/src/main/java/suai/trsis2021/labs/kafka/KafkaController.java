package suai.trsis2021.labs.kafka;

import com.fasterxml.jackson.core.JsonProcessingException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import suai.trsis2021.labs.entity.ItemEntity;

@RestController
public class KafkaController {
    @Autowired
    KafkaProducer producer;

    @Autowired
    KafkaConsumer consumer;

    @PostMapping("/kafka-add")
    public String sendMessage(@RequestBody ItemEntity item) throws JsonProcessingException {
        this.producer.sendMessage(item);
        return "Successfully";
    }
}