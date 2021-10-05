import Model.Items.Name;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Main {
    public static void main(String[] args) {
        ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext(
                "applicationContext.xml"
        );

        Name name = context.getBean("testBean", Name.class);
        System.out.println(name.getName());

        context.close();
    }
}

