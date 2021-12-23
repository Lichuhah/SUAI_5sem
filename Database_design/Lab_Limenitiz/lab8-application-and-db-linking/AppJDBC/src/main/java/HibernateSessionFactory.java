import lombok.Getter;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.boot.MetadataSources;
import org.hibernate.boot.registry.StandardServiceRegistry;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;

public class HibernateSessionFactory {
    @Getter private static final SessionFactory sessionFactory = buildSessionFactory();
    // @Getter private static final Session session = sessionFactory.openSession();

    protected static SessionFactory buildSessionFactory() {
        final StandardServiceRegistry registry = new StandardServiceRegistryBuilder()
                .configure()
                .build();

        return new MetadataSources( registry ).buildMetadata().buildSessionFactory();
    }

    public static Session createSession(){
        return sessionFactory.openSession();
    }
}
