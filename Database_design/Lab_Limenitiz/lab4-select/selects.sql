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


# select а
select p.namePerformance, r.nameRole, c.nameClothes
    from clothes_role cr
        right join clothes c
            on cr.id_clothes = c.id_clothes
        right join role r
            on cr.id_role = r.id_role
        right join performance p
            on r.id_performance = p.id_performance
    where LOWER(nameClothes) LIKE '%принц%'
;


# select б
select c.nameClothes, cd.colorDetail, td.nameType
    from clothes c
        inner join clothes_concrete_detail ccd
            on c.id_clothes = ccd.id_clothes
        inner join concrete_detail cd
            on ccd.id_concrete_detail = cd.id_concrete_detail
        inner join type_detail td
            on cd.id_type_detail = td.id_type_detail
    where LOWER(nameType) LIKE '%плащ%' or
          LOWER(nameType) LIKE '%штаны%';


# select в
select namePerformance
    from performance
        left outer join role r
            on performance.id_performance = r.id_performance
    where ISNULL(r.id_performance);


# select г
select nameRole, nameClothes, dataCreate from clothes_role
    inner join clothes c
        on clothes_role.id_clothes = c.id_clothes
    inner join role r
        on clothes_role.id_role = r.id_role
;

# select д


# select е


# select ж
select firstNameAuthor, nameClothes, namePerformance
    from clothes_author ca
        left join author a
            on a.id_author = ca.id_author
        left join clothes c
            on c.id_clothes = ca.id_clothes
        left join clothes_role cr
            on c.id_clothes = cr.id_clothes
        left join role r
            on cr.id_role = r.id_role
        left join performance p
            on r.id_performance = p.id_performance
    # попробовать except

#    where lower(namePerformance) like lower('%Мастер%')
#      and lower(namePerformance) not like lower('%Золушка%')
;


