package suai.trsis2021.lab4.kafka;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.core.KafkaTemplate;
import org.springframework.stereotype.Service;
import suai.trsis2021.lab4.entity.CostEntity;

@Service
public class KafkaProducer {
    private static final String TOPIC = "ADD-EVENT";

    @Autowired
    private KafkaTemplate<String, String> kafkaTemplate;

    public void sendMessage(CostEntity cost) throws JsonProcessingException {
        ObjectMapper mapper = new ObjectMapper();
        String message  = mapper.writeValueAsString(cost);
        this.kafkaTemplate.send(TOPIC, message);
    }
}
