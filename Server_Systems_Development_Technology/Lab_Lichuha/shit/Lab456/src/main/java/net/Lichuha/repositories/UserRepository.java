package net.Lichuha.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import net.Lichuha.entities.User;


/**
 * @author Ramesh Fadatare
 *
 */
public interface UserRepository extends JpaRepository<User, Integer>
{

}