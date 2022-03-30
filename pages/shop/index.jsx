import React from 'react';
import Helmet from 'react-helmet';

import ALink from '~/components/features/custom-link';

import SidebarFilterOne from '~/components/partials/shop/sidebar/sidebar-filter-one'
import ProductListOne from '~/components/partials/shop/product-list/product-list-one';

function Shop() {
    return (
        <main className="main bt-lg-none shop">
            <Helmet>
                <title>Riode React eCommerce Template - Shop Banner Sidebar Page</title>
            </Helmet>

            <h1 className="d-none">Riode React eCommerce Template - Shop Banner Sidebar Page</h1>

            <div className="page-content mb-10 pb-2">
                <div className="container">
                    <ul className="breadcrumb breadcrumb-sm">
                        <li><ALink href="/"><i className="d-icon-home"></i></ALink></li>
                        <li>Shop</li>
                    </ul>

                    <div className="row gutter-lg main-content-wrap">
                        <SidebarFilterOne type="banner" />

                        <div className="col-lg-9 main-content">
                            <div className="shop-banner banner" style={ { backgroundImage: "url('./images/home/shop-banner.jpg')", backgroundColor: "#f2f2f3" } }>
                                <div className="banner-content">
                                    <h4 className="banner-subtitle d-inline-block mb-2 text-secondary text-uppercase ls-normal bg-dark">Through thursday</h4>
                                    <h1 className="banner-title font-weight-bold ls-normal text-uppercase">20% Off Suede Shoes</h1>
                                    <ALink href="/shop" className="btn btn-outline btn-dark btn-rounded">Shop now</ALink>
                                </div>
                            </div>

                            <ProductListOne type="banner" />
                        </div>
                    </div>
                </div>
            </div>
        </main >
    )
}

export default React.memo( Shop );