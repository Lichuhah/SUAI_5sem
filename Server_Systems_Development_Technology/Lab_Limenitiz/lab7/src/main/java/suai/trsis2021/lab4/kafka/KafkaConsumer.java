package suai.trsis2021.lab4.kafka;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.apache.kafka.clients.consumer.ConsumerRecord;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.annotation.KafkaListener;
import org.springframework.kafka.core.KafkaTemplate;
import org.springframework.stereotype.Service;
import suai.trsis2021.lab4.entity.CostEntity;
import suai.trsis2021.lab4.repository.CostRepository;
import suai.trsis2021.lab4.service.CostService;

import java.io.IOException;

@Service
public class KafkaConsumer {
    @Autowired
    CostService costService;

    @KafkaListener(topics = "ADD-EVENT", groupId = "group0")
    public void consume(ConsumerRecord<String,String> message) throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        CostEntity costModel = mapper.readValue(message.value(), CostEntity.class);
        costService.addCost(costModel);
    }
}
