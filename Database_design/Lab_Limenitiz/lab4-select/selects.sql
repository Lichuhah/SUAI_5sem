# clothes + details list
select c.nameClothes, cd.colorDetail, td.nameType, ccd.id_concrete_detail
    from clothes_concrete_detail ccd
        inner join concrete_detail cd
        on ccd.id_concrete_detail = cd.id_concrete_detail
        inner join type_detail td
        on cd.id_type_detail = td.id_type_detail
        inner join clothes c
        on ccd.id_clothes = c.id_clothes;


# details list
select colorDetail, nameType, id_concrete_detail
from concrete_detail cd
    inner join type_detail td
    on cd.id_type_detail = td.id_type_detail
group by cd.id_concrete_detail;

# ================================================

# а. спектакли, в которых используются костюмы, имеющие в названии слово «принц»
select p.namePerformance, r.nameRole, c.nameClothes
    from clothes_role cr
        join clothes c
            on cr.id_clothes = c.id_clothes
        join role r
            on cr.id_role = r.id_role
        join performance p
            on r.id_performance = p.id_performance
    where LOWER(nameClothes) LIKE '%принц%';

# б. костюм, в котором есть и плащ и штаны
select c.nameClothes, cd.colorDetail, td.nameType, td2.nameType
    from clothes c
        join clothes_concrete_detail ccd
            on c.id_clothes = ccd.id_clothes
        join concrete_detail cd
            on ccd.id_concrete_detail = cd.id_concrete_detail
        join type_detail td
            on cd.id_type_detail = td.id_type_detail

        join clothes_concrete_detail ccd2
            on c.id_clothes = ccd2.id_clothes
        join concrete_detail cd2
            on ccd2.id_concrete_detail = cd2.id_concrete_detail
        join type_detail td2
            on cd2.id_type_detail = td2.id_type_detail
    where LOWER(TD.nameType) like '%плащ%' and
          LOWER(TD2.nameType) like '%штаны%';

# в. спектакль, на который пока нет костюмов
select namePerformance
    from performance
        left outer join role r
            on performance.id_performance = r.id_performance
        left outer join clothes_role cr
            on r.id_role = cr.id_role
        left outer join clothes c
            on cr.id_clothes = c.id_clothes
    where r.id_performance is null or c.id_clothes is null;

select namePerformance
    from clothes c
        right outer join clothes_role cr
            on cr.id_clothes = c.id_clothes
        right outer join role r
            on r.id_role = cr.id_role
        right outer join performance p
            on p.id_performance = r.id_performance
    where r.id_performance is null or c.id_clothes is null;
