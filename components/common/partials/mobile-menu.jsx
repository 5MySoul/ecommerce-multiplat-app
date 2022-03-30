import React, { useEffect, useState } from 'react';
import { Tabs, TabList, Tab, TabPanel } from 'react-tabs';
import { useRouter } from 'next/router';
import SlideToggle from 'react-slide-toggle';

import ALink from '~/components/features/custom-link';
import Card from '~/components/features/accordion/card';

import { mainMenu } from '~/utils/data/menu';



function MobileMenu () {
    const [ search, setSearch ] = useState( "" );
    const router = useRouter();
    const query = router.query;

    useEffect( () => {
        window.addEventListener( 'resize', hideMobileMenuHandler );
        document.querySelector( "body" ).addEventListener( "click", onBodyClick );

        return () => {
            window.removeEventListener( 'resize', hideMobileMenuHandler );
            document.querySelector( "body" ).removeEventListener( "click", onBodyClick );
        }
    }, [] )

    useEffect( () => {
        setSearch( "" );
    }, [ router.query.slug ] )

    const hideMobileMenuHandler = () => {
        if ( window.innerWidth > 991 ) {
            document.querySelector( 'body' ).classList.remove( 'mmenu-active' );
        }
    }

    const hideMobileMenu = () => {
        document.querySelector( 'body' ).classList.remove( 'mmenu-active' );
    }

    function onSearchChange ( e ) {
        setSearch( e.target.value );
    }

    function onBodyClick ( e ) {
        if ( e.target.closest( '.header-search' ) ) return e.target.closest( '.header-search' ).classList.contains( 'show-results' ) || e.target.closest( '.header-search' ).classList.add( 'show-results' );

        document.querySelector( '.header-search.show' ) && document.querySelector( '.header-search.show' ).classList.remove( 'show' );
        document.querySelector( '.header-search.show-results' ) && document.querySelector( '.header-search.show-results' ).classList.remove( 'show-results' );
    }

    function onSubmitSearchForm ( e ) {
        e.preventDefault();
        router.push( {
            pathname: '/shop',
            query: {
                search: search
            }
        } );
    }

    return (
        <div className="mobile-menu-wrapper">
            <div className="mobile-menu-overlay" onClick={ hideMobileMenu }>
            </div>

            <ALink className="mobile-menu-close" href="#" onClick={ hideMobileMenu }><i className="d-icon-times"></i></ALink>

            <div className="mobile-menu-container scrollable">
                <form action="#" className="input-wrapper" onSubmit={ onSubmitSearchForm }>
                    <input type="text" className="form-control" name="search" autoComplete="off" value={ search } onChange={ onSearchChange }
                        placeholder="Search your keyword..." required />
                    <button className="btn btn-search" type="submit">
                        <i className="d-icon-search"></i>
                    </button>
                </form>

                <Tabs selectedTabClassName="active" selectedTabPanelClassName="active" className="tab tab-nav-simple tab-nav-boxed form-tab mt-5">
                    <TabList className="nav nav-tabs nav-fill">
                        <Tab className="nav-item">
                            <span className="nav-link">Menu</span>
                        </Tab>
                        <Tab className="nav-item">
                            <span className="nav-link">Categories</span>
                        </Tab>
                    </TabList>
                    <div className="tab-content">
                        <TabPanel className="tab-pane">
                            <ul className="mobile-menu mmenu-anim">
                                <li>
                                    <ALink href="/">Home</ALink>
                                </li>

                                <li>
                                    <Card title="categories" type="mobile" url="/shop">
                                        <ul>
                                            <li>
                                                <Card title="Variations 1" type="mobile">
                                                    <ul>
                                                        {
                                                            mainMenu.shop.variation1.map( ( item, index ) => (
                                                                <li key={ `shop-${ item.title }` }>
                                                                    <ALink href={ '/' + item.url }>
                                                                        { item.title }
                                                                        { item.hot ? <span className="tip tip-hot">Hot</span> : "" }
                                                                    </ALink>
                                                                </li>
                                                            ) )
                                                        }
                                                    </ul>
                                                </Card>
                                            </li>
                                            <li>
                                                <Card title="Variations 2" type="mobile">
                                                    <ul>
                                                        {
                                                            mainMenu.shop.variation2.map( ( item, index ) => (
                                                                <li key={ `shop-${ item.title }` }>
                                                                    <ALink href={ '/' + item.url }>
                                                                        { item.title }
                                                                        { item.new ? <span className="tip tip-new">New</span> : "" }
                                                                    </ALink>
                                                                </li>
                                                            ) )
                                                        }
                                                    </ul>
                                                </Card>
                                            </li>
                                        </ul>
                                    </Card>
                                </li>

                                <li>
                                    <Card title="Products" type="mobile" url="/product/default/woman-dress">
                                        <ul>
                                            <li>
                                                <Card title="Product Pages" type="mobile">
                                                    {
                                                        mainMenu.product.pages.map( ( item, index ) => (
                                                            <ALink href={ '/' + item.url } key={ `product-${ item.title }` }>
                                                                { item.title }
                                                                { item.hot ? <span className="tip tip-hot">Hot</span> : "" }
                                                            </ALink>
                                                        ) )
                                                    }
                                                </Card>
                                            </li>

                                            <li>
                                                <Card title="Product Layouts" type="mobile">
                                                    <ul>
                                                        {
                                                            mainMenu.product.layout.map( ( item, index ) => (
                                                                <li key={ `product-${ item.title }` }>
                                                                    <ALink href={ '/' + item.url }>
                                                                        { item.title }
                                                                        { item.new ? <span className="tip tip-new">New</span> : "" }
                                                                    </ALink>
                                                                </li>
                                                            ) )
                                                        }
                                                    </ul>
                                                </Card>
                                            </li>
                                        </ul>
                                    </Card>
                                </li>

                                <li>
                                    <Card title="Pages" type="mobile" url="/pages/about-us">
                                        <ul>
                                            {
                                                mainMenu.other.map( ( item, index ) => (
                                                    <li key={ `other-${ item.title }` }>
                                                        <ALink href={ '/' + item.url }>
                                                            { item.title }
                                                            { item.new ? <span className="tip tip-new">New</span> : "" }
                                                        </ALink>
                                                    </li>
                                                ) )
                                            }
                                        </ul>
                                    </Card>
                                </li>

                                <li>
                                    <Card title="Blog" type="mobile" url="/blog/classic">
                                        <ul>
                                            {
                                                mainMenu.blog.map( ( item, index ) => (
                                                    item.subPages ?
                                                        <li key={ "blog" + item.title }>
                                                            <Card title={ item.title } url={ '/' + item.url } type="mobile">
                                                                <ul>
                                                                    {
                                                                        item.subPages.map( ( item, index ) => (
                                                                            <li key={ `blog-${ item.title }` }>
                                                                                <ALink href={ '/' + item.url }>
                                                                                    { item.title }
                                                                                </ALink>
                                                                            </li>
                                                                        ) )
                                                                    }
                                                                </ul>
                                                            </Card>
                                                        </li> :

                                                        <li key={ "blog" + item.title } className={ item.subPages ? "submenu" : "" }>
                                                            <ALink href={ '/' + item.url }>
                                                                { item.title }
                                                            </ALink>
                                                        </li>
                                                ) )
                                            }
                                        </ul>
                                    </Card>
                                </li>

                                <li>
                                    <Card title="elements" type="mobile" url="/elements">
                                        <ul>
                                            {
                                                mainMenu.element.map( ( item, index ) => (
                                                    <li key={ `elements-${ item.title }` }>
                                                        <ALink href={ '/' + item.url }>
                                                            { item.title }
                                                        </ALink>
                                                    </li>
                                                ) )
                                            }
                                        </ul>
                                    </Card>
                                </li>

                                <li><ALink href="#">Buy Riode!</ALink></li>
                            </ul>
                        </TabPanel>

                        <TabPanel>
                            <ul className="mobile-menu">
                                <li><ALink href="/shop" class="menu-title">Browse Our Categories</ALink></li>

                                <SlideToggle duration={ 300 } collapsed >
                                    { ( { onToggle, setCollapsibleElement, toggleState } ) => (
                                        <li className={ `submenu ${ toggleState === 'EXPANDED' ? 'show' : '' }` }>
                                            <ALink href={ { pathname: '/shop', query: { category: 'electronics', grid: query.grid } } } scroll={ false }>
                                                <i className="d-icon-camera1"></i>Electronics
                                                <span className={ `toggle-btn ${ toggleState.toLowerCase() }` } onClick={ e => { e.stopPropagation(); e.preventDefault(); onToggle(); } }></span>
                                            </ALink>

                                            <div ref={ setCollapsibleElement } style={ { overflow: 'hidden' } }>
                                                <ul style={ { display: "block", background: "#232323" } }>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'air-conditioners' } } } scroll={ false }>Air Conditioners</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'machines' } } } scroll={ false }>Machines</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'musical-instrument' } } } scroll={ false }>Musical Instrument</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'office-electronics' } } } scroll={ false }>Office Electronics</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'televisions' } } } scroll={ false }>Televisions</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'video-recoders' } } } scroll={ false }>Video Recorders</ALink></li>
                                                </ul>
                                            </div>
                                        </li>
                                    ) }
                                </SlideToggle>

                                <li>
                                    <ALink href={ { pathname: '/shop', query: { category: 'backpacks-and-fashion-bags' } } }><i className="d-icon-officebag"></i>Backpacks &amp; Fashion Bags</ALink>
                                </li>

                                <SlideToggle duration={ 300 } collapsed >
                                    { ( { onToggle, setCollapsibleElement, toggleState } ) => (
                                        <li className={ `submenu ${ toggleState === 'EXPANDED' ? 'show' : '' }` }>
                                            <ALink href={ { pathname: '/shop', query: { category: 'fashion-and-clothings', grid: query.grid } } } scroll={ false }>
                                                <i className="d-icon-t-shirt1" style={ { fontSize: "22px", marginRight: ".7rem" } }></i>Travel &amp; Clothings
                                                <span className={ `toggle-btn ${ toggleState.toLowerCase() }` } onClick={ e => { e.stopPropagation(); e.preventDefault(); onToggle(); } }></span>
                                            </ALink>

                                            <div ref={ setCollapsibleElement } style={ { overflow: 'hidden' } }>
                                                <ul style={ { display: "block", background: "#232323" } }>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'bikinies' } } } scroll={ false }>Bikinies</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'casual-dresses' } } } scroll={ false }>Casual Dresses</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'hair-accessories-and-hats' } } } scroll={ false }>Hair Accessories &amp; Hats</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'jackets' } } } scroll={ false }>Jackets</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'jumpsuits-and-t-shirts' } } } scroll={ false }>Jumpsuits &amp; T-Shirts</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'fashion-new-arrivals' } } } scroll={ false }>New Arrivals</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'summer-dresses' } } } scroll={ false }>Summer Dresses</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'sunglasses' } } } scroll={ false }>Sunglasses</ALink></li>
                                                </ul>
                                            </div>
                                        </li>
                                    ) }
                                </SlideToggle>

                                <SlideToggle duration={ 300 } collapsed >
                                    { ( { onToggle, setCollapsibleElement, toggleState } ) => (
                                        <li className={ `submenu ${ toggleState === 'EXPANDED' ? 'show' : '' }` }>
                                            <ALink href={ { pathname: '/shop', query: { category: 'computers', grid: query.grid } } } scroll={ false }>
                                                <i className="d-icon-desktop"></i>Computers
                                                <span className={ `toggle-btn ${ toggleState.toLowerCase() }` } onClick={ e => { e.stopPropagation(); e.preventDefault(); onToggle(); } }></span>
                                            </ALink>

                                            <div ref={ setCollapsibleElement } style={ { overflow: 'hidden' } }>
                                                <ul style={ { display: "block", background: "#232323" } }>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'desktop-pcs' } } } scroll={ false }>Desktop PCs</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'laptops' } } } scroll={ false }>Laptops</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'computer-new-arrivals' } } } scroll={ false }>New Arrivals</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'pc-components' } } } scroll={ false }>PC Components</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'pc-gaming' } } } scroll={ false }>PC Gaming</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'storage-and-memory' } } } scroll={ false }>Storage & Memory</ALink></li>
                                                </ul>
                                            </div>
                                        </li>
                                    ) }
                                </SlideToggle>

                                <SlideToggle duration={ 300 } collapsed >
                                    { ( { onToggle, setCollapsibleElement, toggleState } ) => (
                                        <li className={ `submenu ${ toggleState === 'EXPANDED' ? 'show' : '' }` }>
                                            <ALink href={ { pathname: '/shop', query: { category: 'beauty-and-fragrance', grid: query.grid } } } scroll={ false }>
                                                <i className="d-icon-heart"></i>Beauty &amp; Fragrance
                                                <span className={ `toggle-btn ${ toggleState.toLowerCase() }` } onClick={ e => { e.stopPropagation(); e.preventDefault(); onToggle(); } }></span>
                                            </ALink>

                                            <div ref={ setCollapsibleElement } style={ { overflow: 'hidden' } }>
                                                <ul style={ { display: "block", background: "#232323" } }>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'hair-care' } } } scroll={ false }>Hair Care</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'makeup' } } } scroll={ false }>Makeup</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'beauty-new-arrivals' } } } scroll={ false }>New Arrivals</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'perfumes' } } } scroll={ false }>Perfumes</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'skin-care' } } } scroll={ false }>Skin Care</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'tools-and-equipments' } } } scroll={ false }>Tools &amp; Equipments</ALink></li>
                                                </ul>
                                            </div>
                                        </li>
                                    ) }
                                </SlideToggle>

                                <li>
                                    <ALink href={ { pathname: '/shop', query: { category: 'headgears' } } }>
                                        <i className="d-icon-hat" style={ { fontSize: "22px", marginRight: ".8rem" } }></i>Headgears
                                    </ALink>
                                </li>

                                <SlideToggle duration={ 300 } collapsed >
                                    { ( { onToggle, setCollapsibleElement, toggleState } ) => (
                                        <li className={ `submenu ${ toggleState === 'EXPANDED' ? 'show' : '' }` }>
                                            <ALink href={ { pathname: '/shop', query: { category: 'home-and-kitchen', grid: query.grid } } } scroll={ false }>
                                                <i className="d-icon-cook"></i>Home &amp; Kitchen
                                                <span className={ `toggle-btn ${ toggleState.toLowerCase() }` } onClick={ e => { e.stopPropagation(); e.preventDefault(); onToggle(); } }></span>
                                            </ALink>

                                            <div ref={ setCollapsibleElement } style={ { overflow: 'hidden' } }>
                                                <ul style={ { display: "block", background: "#232323" } }>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'cookwaves' } } } scroll={ false }>Cookwaves</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'decor' } } } scroll={ false }>Decor</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'furnitures' } } } scroll={ false }>Furniture</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'garden-tools' } } } scroll={ false }>Garden Tools</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'home-new-arrivals' } } } scroll={ false }>New Arrivals</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'utensil-and-gadgets' } } } scroll={ false }>Utensil &amp; Gadgets</ALink></li>
                                                </ul>
                                            </div>
                                        </li>
                                    ) }
                                </SlideToggle>

                                <SlideToggle duration={ 300 } collapsed >
                                    { ( { onToggle, setCollapsibleElement, toggleState } ) => (
                                        <li className={ `submenu ${ toggleState === 'EXPANDED' ? 'show' : '' }` }>
                                            <ALink href={ { pathname: '/shop', query: { category: 'jewelry-and-watches', grid: query.grid } } } scroll={ false }>
                                                <i className="d-icon-watch"></i>Jewelry &amp; Watches
                                                <span className={ `toggle-btn ${ toggleState.toLowerCase() }` } onClick={ e => { e.stopPropagation(); e.preventDefault(); onToggle(); } }></span>
                                            </ALink>

                                            <div ref={ setCollapsibleElement } style={ { overflow: 'hidden' } }>
                                                <ul style={ { display: "block", background: "#232323" } }>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'accessories' } } } scroll={ false }>Accessories</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'bracelets' } } } scroll={ false }>Bracelets</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'necklace' } } } scroll={ false }>Necklace</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'pendant' } } } scroll={ false }>Pendant</ALink></li>
                                                    <li><ALink href={ { pathname: '/shop', query: { category: 'watch' } } } scroll={ false }>Watch</ALink></li>
                                                </ul>
                                            </div>
                                        </li>
                                    ) }
                                </SlideToggle>

                                <li>
                                    <ALink href={ { pathname: '/shop', query: { category: 'shoes' } } }>
                                        <i className="d-icon-shoes"
                                            style={ { fontSize: "2.2rem", marginRight: ".8rem" } }></i>Shoes
                                    </ALink>
                                </li>
                            </ul>
                        </TabPanel>
                    </div>
                </Tabs>
            </div>
        </div>
    )
}

export default React.memo( MobileMenu );