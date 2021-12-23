package suai.trsis2021.labs.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import suai.trsis2021.labs.entity.ItemEntity;
import suai.trsis2021.labs.exceptions.ItemNotFoundException;
import suai.trsis2021.labs.model.Item;
import suai.trsis2021.labs.repository.ItemRepository;

import java.util.LinkedList;
import java.util.List;
import java.util.Optional;

@Service
@Transactional
public class ItemService {

    @Autowired
    private ItemRepository itemRepository;

    public boolean addItem(ItemEntity item){
        if(isEmptyItem(item)) {
            return false;
        }

        try {
            ItemEntity c = findItemEntity(item);
            if(c == null){
                itemRepository.save(item);
            }
            else{
                c.countUp();
                updateItemById(c);
            }
            return true;
        }
        catch (Exception e){
            e.printStackTrace();
            return false;
        }
    }

    public boolean deleteItem(Long id){
        try {
            Optional<ItemEntity> c = itemRepository.findById(id);
            if(c.isEmpty()){
                return false;
            }

            ItemEntity item = c.get();
            if(item.getCount() > 1){
                item.countDown();
                updateItemById(item);
            }
            else{
                itemRepository.deleteById(id);
            }
            return true;

        }catch (Exception e){
            return false;
        }
    }

    public boolean putItem(ItemEntity item){
        if(isEmptyItem(item)) {
            return false;
        }

        Optional<ItemEntity> c = itemRepository.findById(item.getId());
        if(c.isEmpty()){
            return false;
        }

        ItemEntity itemEntity = c.get();
        itemEntity.setSection(item.getSection());
        itemEntity.setName(item.getName());
        itemEntity.setDateAdd(item.getDateAdd());
        itemEntity.setStorageTime(item.getStorageTime());
        itemEntity.setStoragePrice(item.getStoragePrice());
        updateItemById(itemEntity);
        return true;
    }

    public List<Item> getItems(){
        List<Item> items = new LinkedList<>();
        itemRepository.findAll().forEach(e -> items.add(Item.toModel(e)));
        return items;
    }

    public Item getItem(Long id) throws ItemNotFoundException {
        var item = itemRepository.findById(id);
        if(item.isEmpty()){
            throw new ItemNotFoundException("Item don't found");
        }
        return Item.toModel(item.get());
    }

    public ItemEntity findItemEntity(ItemEntity item) {
        for (var c : itemRepository.findByName(item.getName())) {
            if (equalItems(c, item)) {
                return c;
            }
        }
        return null;
    }

    private void updateItemById(ItemEntity item){
        itemRepository.updateCostById(
            item.getSection(),
            item.getName(),
            item.getDateAdd(),
            item.getStorageTime(),
            item.getStoragePrice(),
            item.getCount(),
            item.getId()
        );
    }

    private boolean equalItems(ItemEntity e1, ItemEntity e2){
        return e1.getSection().equals(e2.getSection())
                && e1.getName().equals(e2.getName())
                && e1.getDateAdd().equals(e2.getDateAdd())
                && e1.getStorageTime().equals(e2.getStorageTime())
                && e1.getStoragePrice().equals(e2.getStoragePrice());
    }

    private boolean isEmptyItem(ItemEntity item){
        return item.getSection() == null
            || item.getName() == null
            || item.getDateAdd() == null
            || item.getStorageTime() == null
            || item.getStoragePrice() == null;
    }
}
