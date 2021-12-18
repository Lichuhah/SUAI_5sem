/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package labs.lab2.kafka;

import labs.lab2.db.model.Book;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.core.KafkaTemplate;
import org.springframework.stereotype.Service;


@Service

public class KafkaProducer {    
    
    private static final String TOPIC = "TEST2";

    @Autowired
    private KafkaTemplate<String, String> kafkaTemplate;

    public void sendMessage(Book authorModel) throws JsonProcessingException {
        ObjectMapper mapper = new ObjectMapper();
        String message  = mapper.writeValueAsString(authorModel);
        this.kafkaTemplate.send(TOPIC, message);
    }

}
