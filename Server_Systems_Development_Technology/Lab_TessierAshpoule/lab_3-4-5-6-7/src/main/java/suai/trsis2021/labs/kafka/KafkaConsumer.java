package suai.trsis2021.labs.kafka;

import com.fasterxml.jackson.databind.ObjectMapper;
import org.apache.kafka.clients.consumer.ConsumerRecord;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.annotation.KafkaListener;
import org.springframework.stereotype.Service;
import suai.trsis2021.labs.entity.ItemEntity;
import suai.trsis2021.labs.repository.ItemRepository;

import java.io.IOException;

@Service
public class KafkaConsumer {
    @Autowired
    ItemRepository itemRepository;

    @KafkaListener(topics = "TRSISLAB77", groupId = "group0")
    public void consume(ConsumerRecord<String,String> message) throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        ItemEntity authorModel = mapper.readValue(message.value(), ItemEntity.class);
        itemRepository.save(authorModel);
    }
}