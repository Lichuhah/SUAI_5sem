/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package labs.lab2.kafka;

import labs.lab2.db.model.Book;
import labs.lab2.db.dao.BookRepository;
import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.IOException;
import org.apache.kafka.clients.consumer.ConsumerRecord;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.annotation.KafkaListener;
import org.springframework.stereotype.Service;


@Service
public class KafkaConsumer {

    @Autowired
    BookRepository bookRepository;

    @KafkaListener(topics = "TEST1", groupId = "group0")
    public void consume(ConsumerRecord<String,String> message) throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        Book authorModel = mapper.readValue(message.value(), Book.class);
        bookRepository.save(authorModel);
    }

}
