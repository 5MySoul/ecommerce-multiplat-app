import React, { useEffect } from 'react';
import Reveal from 'react-awesome-reveal';
import { useLazyQuery } from '@apollo/react-hooks';

import ALink from '~/components/features/custom-link';

import ProductTwo from '~/components/features/product/product-two';

import withApollo from '~/server/apollo';
import { GET_PRODUCTS } from '~/server/queries';

import { fadeIn, fadeInUpShorter } from '~/utils/data/keyframes';
import { categoryList } from '~/utils/data/menu';

function ProductCollection ( props ) {
    const { id = 0, subTitle = "Featured", title = "Fashion Design", titleAdClass = 'ls-s', url = "./images/home/banner/3.jpg", adClass = '', wrapperAdClass = '' } = props;

    const [ getProducts, { data, loading, error } ] = useLazyQuery( GET_PRODUCTS );
    const products = data && data.products.data;

    useEffect( () => {
        getProducts( {
            variables: {
                category: categoryList[ id ].slug
            }
        } );
    }, [] )

    function activeHandler ( e ) {
        console.log( e.currentTarget.closest( '.category-list' ) )
        e.currentTarget.closest( '.category-list' ).querySelector( '.show' ) && e.currentTarget.closest( '.category-list' ).querySelector( '.show' ).classList.remove( 'show' );
        e.currentTarget.classList.add( "show" );
    }

    return (
        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
            <section className={ `product-wrapper row gutter-no ${ wrapperAdClass }` }>
                <div className="row gutter-no products-banner">
                    <div className="col-12 col-xs-6 mb-0">
                        <div className="category-filters d-flex flex-column">
                            <Reveal keyframes={ fadeInUpShorter } delay={ 200 } duration={ 1200 } triggerOnce>
                                <h3 className="category-title font-weight-bold" >{ categoryList[ id ].name }</h3>
                            </Reveal>

                            <Reveal keyframes={ fadeInUpShorter } delay={ 300 } duration={ 1200 } triggerOnce>
                                <ul className="category-list">
                                    {
                                        categoryList[ id ].children.map( ( item, index ) =>
                                            <li key={ 'category-filter' + item + index } onClick={ activeHandler }>
                                                <ALink href="#" onClick={ () => getProducts( {
                                                    variables: {
                                                        category: item.slug
                                                    }
                                                } ) }>{ item.name }</ALink>
                                            </li>
                                        )
                                    }
                                </ul>
                            </Reveal>

                            <Reveal keyframes={ fadeInUpShorter } delay={ 300 } duration={ 1200 } triggerOnce>
                                <ALink href={ { pathname: "/shop", query: { category: categoryList[ id ].slug } } } className="btn btn-link btn-underline font-primary">View all products<i className="d-icon-arrow-right"></i></ALink>
                            </Reveal>
                        </div>
                    </div>
                    <div className="banner col-12 col-xs-6 mb-0" style={ { backgroundImage: `url(${ url })`, backgroundColor: "#ebebeb" } }>
                        <div className={ `banner-content ${ adClass }` }>
                            <Reveal keyframes={ fadeInUpShorter } delay={ 400 } duration={ 1200 } triggerOnce>
                                <h4 className="banner-subtitle mb-2 ls-s font-weight-normal">{ subTitle }</h4>
                                <h3 className={ `banner-title ${ titleAdClass }` }>{ title }<br /><span className="d-inline-block font-weight-normal">Collection</span></h3>
                                <ALink href={ { pathname: "/shop", query: { category: categoryList[ id ].slug } } } className="btn btn-dark btn-md btn-rounded">shop now</ALink>
                            </Reveal>
                        </div>
                    </div>
                </div>


                <div className="overflow-hidden products-box">
                    <div className="row gutter-no line-grid">
                        {
                            loading ?
                                [ 1, 2, 3, 4, 5, 6 ].map( ( item ) =>
                                    <div className="col-md-4 col-6 mb-0" key={ 'product-skel-' + item }>
                                        <div className="product-loading-overlay"></div>
                                    </div>
                                ) :
                                products && products.slice( 0, 6 ).map( ( item, index ) =>
                                    <div className="col-md-4 col-6 mb-0" key={ 'product-' + index }>
                                        <ProductTwo product={ item } isCat={ false } />
                                    </div>
                                )
                        }
                    </div>
                </div>
            </section>
        </Reveal>
    )
}

export default withApollo( { ssr: typeof window === 'undefined' } )( ProductCollection );
