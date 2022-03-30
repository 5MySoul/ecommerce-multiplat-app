import React, { useEffect, useState } from 'react';
import { useRouter } from 'next/router';
import { useQuery } from '@apollo/react-hooks';
import Helmet from 'react-helmet';
import imagesLoaded from 'imagesloaded';

import withApollo from '~/server/apollo';
import { GET_PRODUCT } from '~/server/queries';

import OwlCarousel from '~/components/features/owl-carousel';
import ALink from '~/components/features/custom-link';

import MediaFive from '~/components/partials/product/media/media-five';
import DetailThree from '~/components/partials/product/detail/detail-three';
import DescOne from '~/components/partials/product/desc/desc-one';
import RelatedProducts from '~/components/partials/product/related-products';
import ProductSidebar from '~/components/partials/product/product-sidebar';
import ProductNav from '~/components/partials/product/product-nav';

import { mainSlider17 } from '~/utils/data/carousel';

function ProductDefault () {
    const slug = useRouter().query.slug;

    if ( !slug ) return '';

    const { data, loading, error } = useQuery( GET_PRODUCT, { variables: { slug } } );
    const [ loaded, setLoadingState ] = useState( false );
    const product = data && data.product.data;
    const related = data && data.product.related;

    useEffect( () => {
        if ( !loading && product )
            imagesLoaded( 'main' ).on( 'done', function () {
                setLoadingState( true );
            } ).on( 'progress', function () {
                setLoadingState( false );
            } );
        if ( loading )
            setLoadingState( false )
    }, [ loading, product ] )

    return (
        <main className="main single-product">
            <Helmet>
                <title>Riode React eCommerce Template | Product Default Page</title>
            </Helmet>

            <h1 className="d-none">Riode React eCommerce Template - Product Default Page</h1>

            {
                product !== undefined ?
                    <div className={ `page-content mb-8 ${ loaded ? '' : 'd-none' }` }>
                        <div className="container skeleton-body">
                            <div className="product-navigation">
                                <ul className="breadcrumb breadcrumb-lg">
                                    <li><ALink href="/"><i className="d-icon-home"></i></ALink></li>
                                    <li><ALink href="#" className="active">Products</ALink></li>
                                    <li>Detail</li>
                                </ul>

                                <ProductNav product={ data.product } />
                            </div>

                            <div className="row gutter-lg">
                                <ProductSidebar />

                                <div className="col-lg-9">
                                    <div className="product product-single row mb-10">
                                        <div className="col-md-6">
                                            <MediaFive product={ product } adClass='pb-0' />
                                        </div>

                                        <div className="col-md-6">
                                            <DetailThree data={ data } isNav={ false } />
                                        </div>
                                    </div>

                                    <DescOne product={ product } isDivider={ false } className="mt-2 m-4" isGuide={ false } />

                                    <RelatedProducts products={ related } />
                                </div>
                            </div>
                        </div>
                    </div> : ''
            }
            {
                loaded && !loading ? ''
                    : <div className="skeleton-body container mb-8 mt-10">
                        <div className="row gutter-lg">
                            <div className="col-lg-3 right-sidebar sidebar-fixed sticky-sidebar-wrapper">
                                <div className="sidebar-content">
                                    <div className="widget-2"></div>
                                </div>
                            </div>
                            <div className="col-lg-9">
                                <div className="row mb-10">
                                    <div className="col-md-6">
                                        <div className="skel-pro-gallery"></div>
                                    </div>

                                    <div className="col-md-6">
                                        <div className="skel-pro-summary"></div>
                                    </div>
                                </div>

                                <div className="skel-pro-tabs"></div>

                                <section className="pt-3 mt-4">
                                    <h2 className="title justify-content-center">Related Products</h2>

                                    <OwlCarousel adClass="owl-carousel owl-theme owl-nav-full" options={ mainSlider17 }>
                                        {
                                            [ 1, 2, 3, 4, 5, 6 ].map( ( item ) =>
                                                <div className="product-loading-overlay" key={ 'popup-skel-' + item }></div>
                                            )
                                        }
                                    </OwlCarousel>
                                </section>
                            </div>
                        </div>
                    </div>
            }
        </main>
    )
}

export default withApollo( { ssr: typeof window === 'undefined' } )( ProductDefault );