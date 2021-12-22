package suai.trsis2021.labs.kafka;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.core.KafkaTemplate;
import org.springframework.stereotype.Service;
import suai.trsis2021.labs.entity.ItemEntity;

@Service
public class KafkaProducer {
    private static final String TOPIC = "TRSISLAB77";

    @Autowired
    private KafkaTemplate<String, String> kafkaTemplate;

    public void sendMessage(ItemEntity item) throws JsonProcessingException {
        ObjectMapper mapper = new ObjectMapper();
        //try {
        String message = mapper.writeValueAsString(item);
        this.kafkaTemplate.send(TOPIC, message);
    }
}