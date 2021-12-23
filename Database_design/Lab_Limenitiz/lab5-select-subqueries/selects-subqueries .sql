# =============================================================================
# select г.
# Запрос с условием на агрегатную функцию.
#       (реализовать с помощью директивы all)
#
# роль, к которой разрабатывался самый старый из костюмов
select nameRole, nameClothes, dataCreate
    from clothes_role
        join clothes c
            on clothes_role.id_clothes = c.id_clothes
        join role r
            on clothes_role.id_role = r.id_role
    where dataCreate >= all (select dataCreate from clothes);

# =============================================================================
# select д.
# Запрос получением агрегатной функции от агрегатной функции.

# автор, разработавший наибольшее число костюмов
select firstNameAuthor, count(*) as count_clothes
    from clothes_author ca join author a on a.id_author = ca.id_author
    group by ca.id_author
    having count(*) = (
        select max(ca_info.count_clothes)
            from (
                select firstNameAuthor, count(*) as count_clothes
                    from clothes_author ca join author a on a.id_author = ca.id_author
                    group by ca.id_author
            ) as ca_info
    );

# =============================================================================
# select е.
# е - Запрос на «все» (реляционное деление). (реализовать с помощью 2 not exists)
# костюм, в котором есть все типы деталей

select distinct nameClothes
    from clothes
    where not exists (
        select *
            from type_detail
            where not exists(
                select *
                    from clothes c
                        join clothes_concrete_detail ccd on c.id_clothes = ccd.id_clothes
                        join concrete_detail cd on cd.id_concrete_detail = ccd.id_concrete_detail
                        join type_detail td on td.id_type_detail = cd.id_type_detail
                    where td.id_type_detail = type_detail.id_type_detail and
                          c.id_clothes = clothes.id_clothes
            )
    );

# -----------------------------------------------------------------------------
# clothes + details list
select c.nameClothes, cd.colorDetail, td.nameType, ccd.id_concrete_detail
    from clothes_concrete_detail ccd
        inner join concrete_detail cd
        on ccd.id_concrete_detail = cd.id_concrete_detail
        inner join type_detail td
        on cd.id_type_detail = td.id_type_detail
        inner join clothes c
        on ccd.id_clothes = c.id_clothes;

# -----------------------------------------------------------------------------
# details list
select colorDetail, nameType, id_concrete_detail
from concrete_detail cd
    inner join type_detail td
    on cd.id_type_detail = td.id_type_detail
group by cd.id_concrete_detail;


# =============================================================================
# select ж.
# ж - Запрос на разность 2 запросов. (реализовать в 3 вариантах: Not in, except (MySQL не поддерживает,
#       поэтому только синтаксис), с использованием левого или правого соединения)
#
#   автор,
#   не разрабатывавший костюмы к «Золушке»,
#   но разрабатывавший к «Мастеру и Маргарите»


# -----------------------------------------------------------------------------
# not in

select firstNameAuthor, a.id_author
    from clothes_author ca
        join author a
            on a.id_author = ca.id_author
        join clothes c
            on c.id_clothes = ca.id_clothes
        join clothes_role cr
            on c.id_clothes = cr.id_clothes
        join role r
            on cr.id_role = r.id_role
        join performance p
            on r.id_performance = p.id_performance
    where
        lower(namePerformance) like lower('%Мастер%')
        and a.id_author not in

(select distinct a.id_author
    from clothes_author ca
        join author a
            on a.id_author = ca.id_author
        join clothes c
            on c.id_clothes = ca.id_clothes
        join clothes_role cr
            on c.id_clothes = cr.id_clothes
        join role r
            on cr.id_role = r.id_role
        join performance p
            on r.id_performance = p.id_performance
    where
        lower(p.namePerformance) like lower('%Золушка%')
);

# -----------------------------------------------------------------------------
# except

/*

(select firstNameAuthor, a.id_author
    from clothes_author ca
        join author a
            on a.id_author = ca.id_author
        join clothes c
            on c.id_clothes = ca.id_clothes
        join clothes_role cr
            on c.id_clothes = cr.id_clothes
        join role r
            on cr.id_role = r.id_role
        join performance p
            on r.id_performance = p.id_performance
    where
        lower(namePerformance) like lower('%Мастер%')
)

except

(select distinct a.id_author
    from clothes_author ca
        join author a
            on a.id_author = ca.id_author
        join clothes c
            on c.id_clothes = ca.id_clothes
        join clothes_role cr
            on c.id_clothes = cr.id_clothes
        join role r
            on cr.id_role = r.id_role
        join performance p
            on r.id_performance = p.id_performance
    where
        lower(p.namePerformance) like lower('%Золушка%')
);

*/

# -----------------------------------------------------------------------------
# left join


select distinct a.id_author
    from clothes_author ca
        join author a
            on a.id_author = ca.id_author
        join clothes c
            on c.id_clothes = ca.id_clothes
        join clothes_role cr
            on c.id_clothes = cr.id_clothes
        join role r
            on cr.id_role = r.id_role
        join performance p
            on r.id_performance = p.id_performance

left join

    (select distinct a.id_author
        from clothes_author ca
            join author a
                on a.id_author = ca.id_author
            join clothes c
                on c.id_clothes = ca.id_clothes
            join clothes_role cr
                on c.id_clothes = cr.id_clothes
            join role r
                on cr.id_role = r.id_role
            join performance p
                on r.id_performance = p.id_performance
        where
            lower(p.namePerformance) like lower('%Золушка%')
    )
    as rt

    on a.id_author = rt.id_author

    where
      lower(p.namePerformance) like lower('%Мастер%')
      and rt.id_author IS NULL;

