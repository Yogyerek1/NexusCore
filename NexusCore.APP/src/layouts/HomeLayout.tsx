import { Outlet } from 'react-router-dom'

const HomeLayout = () => {
    return (
        <div>
            <div></div>
            <main>
                <Outlet />
            </main>
            <div></div>
        </div>
    );
};

export default HomeLayout;