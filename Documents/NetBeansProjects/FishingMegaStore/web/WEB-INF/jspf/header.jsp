<%-- 
    Document   : header
    Created on : 21-Nov-2015, 19:15:04
    Author     : Dereck
--%>
 <%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@taglib prefix="fn" uri="http://java.sun.com/jsp/jstl/functions" %>


<%@page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" type="text/css" href="css/fishingmegastore.css">
        <link rel="shortcut icon" href="img/favicon.ico">

        <title>Fishing Mega Store</title>
    </head>
    <body>
        <div id="main">
            <div id="header">
                <div id="widgetBar">

                    <div class="headerWidget">
                        [ language toggle ]
                    </div>

                <%-- checkout widget --%>
                    <div class="headerWidget">

                       

                        <c:if test="${!empty cart && cart.numberOfItems != 0 &&

                                      !fn:contains(pageContext.request.servletPath,'/checkout') &&
                                      requestScope['javax.servlet.forward.servlet_path'] ne '/checkout' &&

                                      !fn:contains(pageContext.request.servletPath,'/cart') &&
                                      requestScope['javax.servlet.forward.servlet_path'] ne '/cart'}">

                      <a href="checkout" class="bubble">
                        proceed to checkout &#x279f;
                      </a>
                    </c:if>
                    </div>

                <%-- shopping cart widget --%>
                  <div class="headerWidget" id="viewCart">

                    <img src="img/cart.gif" alt="shopping cart icon" id="cart">

                 
                    <span class="horizontalMargin">
                      <c:choose>
                        <c:when test="${cart.numberOfItems == null}">
                          0
                        </c:when>
                        <c:otherwise>
                          ${cart.numberOfItems}
                        </c:otherwise>
                      </c:choose>

                  <%-- Handle singular/plural forms of 'item' --%>
                      <c:choose>
                        <c:when test="${cart.numberOfItems == 1}">
                          item
                        </c:when>
                        <c:otherwise>
                          items
                        </c:otherwise>
                      </c:choose>
                    </span>

                    <c:if test="${!empty cart && cart.numberOfItems != 0 &&

                                  !fn:contains(pageContext.request.servletPath,'/cart') &&
                                  requestScope['javax.servlet.forward.servlet_path'] ne '/cart'}">

                      <a href="viewCart" class="bubble">
                          view cart
                      </a>
                    </c:if>
                </div>
                </div>

                <a href="index.jsp">
                    <img src="img/logo.png" id="logo" alt="Affable Bean logo">
                </a>

                <img src="img/logoText.png" id="logoText" alt="the affable bean">
            </div>