package controller;

import cart.ShoppingCart;
import entity.Category;
import entity.Product;
import java.io.IOException;
import java.util.Collection;
import javax.ejb.EJB;
import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import session.CategoryFacade;
import session.OrderManager;
import session.ProductFacade;

/**
 *
 * @author Dereck
 */
@WebServlet(name = "Controller",
            loadOnStartup = 1,
            urlPatterns = {"/category",
                           "/addToCart",
                           "/viewCart",
                           "/updateCart",
                           "/checkout",
                           "/purchase",
                           "/chooseLanguage"})
public class ControllerServlet extends HttpServlet {

    private String surcharge;

    @EJB
    private CategoryFacade categoryFacade;
    @EJB
    private ProductFacade productFacade;
    @EJB
    private OrderManager orderManager;
    

    @Override
    public void init(ServletConfig servletConfig) throws ServletException {

        super.init(servletConfig);

        
        surcharge = servletConfig.getServletContext().getInitParameter("deliverySurcharge");

       
        getServletContext().setAttribute("categories", categoryFacade.findAll());
    }

    
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        String userPath = request.getServletPath();
        HttpSession session = request.getSession();
        Category selectedCategory;
        Collection<Product> categoryProducts;

        
        if (userPath.equals("/category")) {

            
            String categoryId = request.getQueryString();

            if (categoryId != null) {

                
                selectedCategory = categoryFacade.find(Short.parseShort(categoryId));

                
                session.setAttribute("selectedCategory", selectedCategory);

                
                categoryProducts = selectedCategory.getProductCollection();

                
                session.setAttribute("categoryProducts", categoryProducts);
            }


        
        } else if (userPath.equals("/viewCart")) {

            String clear = request.getParameter("clear");

            if ((clear != null) && clear.equals("true")) {

                ShoppingCart cart = (ShoppingCart) session.getAttribute("cart");
                cart.clear();
            }

            userPath = "/cart";


       
        } else if (userPath.equals("/checkout")) {

            ShoppingCart cart = (ShoppingCart) session.getAttribute("cart");

           
            cart.calculateTotal(surcharge);

           


       
        } else if (userPath.equals("/chooseLanguage")) {
            // TODO: Implement language request

        }

       
        String url = "/WEB-INF/view" + userPath + ".jsp";

        try {
            request.getRequestDispatcher(url).forward(request, response);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }


    
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        String userPath = request.getServletPath();
        HttpSession session = request.getSession();
        ShoppingCart cart = (ShoppingCart) session.getAttribute("cart");

        
        if (userPath.equals("/addToCart")) {

           
            if (cart == null) {

                cart = new ShoppingCart();
                session.setAttribute("cart", cart);
            }

            
            String productId = request.getParameter("productId");

            if (!productId.isEmpty()) {

                Product product = productFacade.find(Integer.parseInt(productId));
                cart.addItem(product);
            }

            userPath = "/category";


        
        } else if (userPath.equals("/updateCart")) {

            
            String productId = request.getParameter("productId");
            String quantity = request.getParameter("quantity");

            Product product = productFacade.find(Integer.parseInt(productId));
            cart.update(product, quantity);

            userPath = "/cart";


        
        } else if (userPath.equals("/purchase")) {
            if(cart != null){
            String name = request.getParameter("name");
            String email = request.getParameter("email");
            String phone = request.getParameter("phone");
            String address = request.getParameter("address");
            String cityRegion = request.getParameter("cityRegion");
            String creditcard = request.getParameter("creditcard");
            
            int OrderId = orderManager.placeOrder(name,email,phone,address,cityRegion,creditcard,cart);
            }

            userPath = "/confirmation";
        }

       
        String url = "/WEB-INF/view" + userPath + ".jsp";

        try {
            request.getRequestDispatcher(url).forward(request, response);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

}