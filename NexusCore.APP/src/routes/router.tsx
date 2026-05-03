import { createBrowserRouter } from "react-router-dom";
import HomeLayout from "../layouts/HomeLayout";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <HomeLayout />,
        children: [
            { path: "/", /*element: <HomePage />*/ }
        ],
    },
    {
        path: "/auth",
        children: [
            { path: "login", /* element: <LoginPage /> */ },
            { path: "register", /* element: <RegisterPage /> */ },
            { path: "forgot-password", /* element: <ForgotPassword /> */ },
        ],
    },
    {
        path: "/checkout",
        /* element: <CheckoutPage />, */
    }
]);